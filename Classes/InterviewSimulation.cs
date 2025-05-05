/// John Coulter
/// Graded Unit 2 Project
/// Job Interviewing and Tracking Application
/// 04/05/2025
/// InterviewSimulation.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GU2.Classes
{
    /// <summary>
    /// InterviewSimulation class simulates an interview by asking questions and tracking the user's progress.
    /// </summary>
    internal class InterviewSimulation
    {
        // Random number generator for selecting questions
        public static readonly Random rnd = new Random();

        // Properties to track the current question, answered questions, and total questions
        private int currentQuestion { get; set; }
        private int answeredQuestions { get; set; }

        private int totalQuestions { get; set; }

        private DateTime startedAt { get; set; }



        /// <summary>
        /// Constructor initializes the InterviewSimulation class.
        /// </summary>
        public InterviewSimulation()
        {
            
            startedAt = DateTime.Now;
            currentQuestion = 0;
            answeredQuestions = 0;

        }
        
        /// <summary>
        /// Asks the next question in the simulation.
        /// </summary>
        /// <returns></returns>
        public (Question, string, string, string, int) AskQuestion()
        {
            string answer = "";
            
            string answered = "No";
            
            currentQuestion++; // Increment the current question number

            Question question = Program.simulationList[currentQuestion - 1]; // Get the current question from the simulation list

            string username = (question.userId == Program.userId) // Check if the question was created by the current user
                ? Program.username
                : "System";

            bool answerExists = Answer.AnswerExists(question.questionId); // Check if an answer already exists for the question

            if (answerExists) // If an answer exists, retrieve the answer text to display
            {
                answer = Answer.GetAnswer(question.questionId);
                answered = "Yes";
            }

            // Return the data to be displayed when the question is asked
            return (question, answer, answered, username, currentQuestion); 

        }

        /// <summary>
        /// Function to get the current question number.
        /// </summary>
        /// <returns></returns>
        public int GetCurrentQuestion()
        {
            
            return currentQuestion;

        }

        /// <summary>
        /// Function to create a list of random questions for the simulation.
        /// </summary>
        /// <param name="numberOfQuestions"></param>
        public void GenerateQuestions(int numberOfQuestions)
        {
            // Clear the simulation list before generating new questions
            Program.simulationList.Clear();

            //Generate questions
            var tempList = Program.questions.ToList();

            // Remove any questions that the user has 'deleted
            tempList.RemoveAll(q => Program.DeletionRecords.Contains(q.questionId));


            // Populate the simulation list with random questions
            for (int i = 0; i < numberOfQuestions; i++)
            {
                var question = tempList[rnd.Next(tempList.Count)];
                Program.simulationList.Add(question);
                tempList.Remove(question);
            }
            // Set the properyt for total number of questions
            this.totalQuestions = Program.simulationList.Count;


        }

        /// <summary>
        /// Function to create and display a report of the interview simulation.
        /// </summary>
        /// <returns></returns>
        public string GenerateReport()
        {
            // Calculate the time spent in the simulation
            TimeSpan timeSpent = DateTime.Now - startedAt;
            string timeSpentMins = timeSpent.ToString(@"mm");
            string timeSpentSeconds = timeSpent.ToString(@"ss");

            return $"Interview Complete at {DateTime.Now}\n\n" +
                $"You have answered {answeredQuestions} out of {totalQuestions} questions.\n\n" +
                $"Time spent in simulation: {timeSpentMins} minutes and {timeSpentSeconds} seconds";
        }

        /// <summary>
        /// FUnction to answer a question during the simulation
        /// </summary>
        /// <param name="answer"></param>
        /// <param name="questionId"></param>
        public void AnswerQuestion(string answer, int questionId)
        {

            this.answeredQuestions++; // increment the number of answered questions during simulation

            // Check if the answer already exists for the question
            bool answerExists = Answer.AnswerExists(questionId);

            if (answerExists) // Warn the user that previous answer will be overwritten
            {                
                var result = MessageBox.Show(
                    "You have previously answered this question!\n\nSaving now will overwrite the previous answer.",
                    "Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    Answer.AnswerQuestion(answer, questionId);
                }
                else
                {
                    // Do nothing, the answer will not be saved
                    return;
                }
            }
            else // If no previous answer exists, save the new answer
            {
                Answer.AnswerQuestion(answer, questionId);
            }
            
        }

        /// <summary>
        /// Function to generate a custom list of questions for the simulation based on user selection during setup.
        /// </summary>
        /// <param name="strengthQuestions"></param>
        /// <param name="pastEvidenceQuestions"></param>
        /// <param name="situationalQuestions"></param>
        /// <param name="technicalQuestions"></param>
        /// <param name="includeIcebreaker"></param>
        /// <param name="includeAnswered"></param>
        public void GenerateQuestions(int strengthQuestions, int pastEvidenceQuestions, int situationalQuestions, int technicalQuestions, bool includeIcebreaker, bool includeAnswered)
        {
            // Clear the simulation list before generating new questions
            Program.simulationList.Clear();

            // Generate seperate lists for each question type, these lists are full of all questions
            var icebreakers = Program.questions.ToList();
            var strengthQuestionsList = Program.questions.ToList();
            var pastEvidenceQuestionsList = Program.questions.ToList();
            var situationalQuestionsList = Program.questions.ToList();
            var technicalQuestionsList = Program.questions.ToList();

            // Keep only the questions that match the question type in each list
            icebreakers.RemoveAll(q => q.questionBehaviour != "Icebreaker");
            strengthQuestionsList.RemoveAll(q => q.questionType != "Strength");
            pastEvidenceQuestionsList.RemoveAll(q => q.questionType != "Past Evidence");
            situationalQuestionsList.RemoveAll(q => q.questionType != "Situational");
            technicalQuestionsList.RemoveAll(q => q.questionType != "Technical");

            // Remove Questions that have been deleted by the user
            icebreakers.RemoveAll(q => Program.DeletionRecords.Contains(q.questionId));
            strengthQuestionsList.RemoveAll(q => Program.DeletionRecords.Contains(q.questionId));
            pastEvidenceQuestionsList.RemoveAll(q => Program.DeletionRecords.Contains(q.questionId));
            situationalQuestionsList.RemoveAll(q => Program.DeletionRecords.Contains(q.questionId));
            technicalQuestionsList.RemoveAll(q => Program.DeletionRecords.Contains(q.questionId));

            
            if (!includeAnswered) // If the user does not want to include answered questions, remove them from the lists
            {                
                icebreakers.RemoveAll(q => Program.AnswerRecords.Contains(q.questionId));
                strengthQuestionsList.RemoveAll(q => Program.AnswerRecords.Contains(q.questionId));
                pastEvidenceQuestionsList.RemoveAll(q => Program.AnswerRecords.Contains(q.questionId));
                situationalQuestionsList.RemoveAll(q => Program.AnswerRecords.Contains(q.questionId));
                technicalQuestionsList.RemoveAll(q => Program.AnswerRecords.Contains(q.questionId));
            }

            // Include Icebreaker if selected
            if (icebreakers.Count > 0 && includeIcebreaker) // Check if any questions of that type are available
            {
                //Add Icebreaker
                var icebreaker = icebreakers[rnd.Next(icebreakers.Count)];
                Program.simulationList.Add(icebreaker);
            }

            // Add questions from each category only if there are any available
            if (strengthQuestions > 0 && strengthQuestionsList.Count > 0) // Check if any questions of that type are available
            {
                for (int i = 0; i < strengthQuestions; i++)
                {
                    if (strengthQuestionsList.Count > 0)
                    {
                        var question = strengthQuestionsList[rnd.Next(strengthQuestionsList.Count)];
                        Program.simulationList.Add(question);
                        strengthQuestionsList.Remove(question);
                    }
                }
            }
            if (pastEvidenceQuestions > 0 && pastEvidenceQuestionsList.Count > 0)
            {
                for (int i = 0; i < pastEvidenceQuestions; i++)
                {
                    if (pastEvidenceQuestionsList.Count > 0)
                    {
                        var question = pastEvidenceQuestionsList[rnd.Next(pastEvidenceQuestionsList.Count)];
                        Program.simulationList.Add(question);
                        pastEvidenceQuestionsList.Remove(question);
                    }
                }
            }
            if (situationalQuestions > 0 && situationalQuestionsList.Count > 0)
            {
                for (int i = 0; i < situationalQuestions; i++)
                {
                    if (situationalQuestionsList.Count > 0)
                    {
                        var question = situationalQuestionsList[rnd.Next(situationalQuestionsList.Count)];
                        Program.simulationList.Add(question);
                        situationalQuestionsList.Remove(question);
                    }
                }
            }
            if (technicalQuestions > 0 && technicalQuestionsList.Count > 0)
            {
                for (int i = 0; i < technicalQuestions; i++)
                {
                    if (technicalQuestionsList.Count > 0)
                    {
                        var question = technicalQuestionsList[rnd.Next(technicalQuestionsList.Count)];
                        Program.simulationList.Add(question);
                        technicalQuestionsList.Remove(question);
                    }
                }
            }
            // Set the property for total number of questions
            this.totalQuestions = Program.simulationList.Count;

        }

    }
  
}
