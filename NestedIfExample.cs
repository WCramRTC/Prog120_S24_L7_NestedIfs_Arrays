using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog120_S24_L7_NestedIfs_Arrays
{
    public class NestedIfExample
    {

        public static char CalculateGrade(int midtermScore, int finalScore, int projectScore)
        {
            double overallScore = 0.0;

            // Weight the different components
            overallScore += 0.3 * midtermScore;
            overallScore += 0.5 * finalScore;
            overallScore += 0.2 * projectScore;

            if (overallScore >= 90)
            {
                return 'A';
            }
            else if (overallScore >= 80)
            {
                return 'B';
            }
            else if (overallScore >= 70)
            {
                return 'C';
            }
            else if (overallScore >= 60)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }

        public static bool IsLoginValid(string username, string password)
        {
            if (username == "admin")
            {
                if (password == "securepassword")
                {
                    return true;
                }
                else
                {
                    return false; // Incorrect password
                }
            }
            else
            {
                return false; // Incorrect username 
            }
        }

        public static double currentBalance = 0;

        public static void ProcessTransaction(string transactionType, double amount)
        {
            if (transactionType == "withdraw")
            {
                if (amount <= currentBalance)
                {
                    currentBalance -= amount;
                    Console.WriteLine("Withdrawal successful.");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else if (transactionType == "deposit")
            {
                currentBalance += amount;
                Console.WriteLine("Deposit successful.");
            }
            else
            {
                Console.WriteLine("Invalid transaction type.");
            }
        }

        public static void EnemyAction()
        {
            //if (playerHealth < 30)
            //{
            //    if (distanceToPlayer < 10)
            //    {
            //        Attack();
            //    }
            //    else
            //    {
            //        ChasePlayer();
            //    }
            //}
            //else
            //{
            //    PatrolArea();
            //}
        }





    } // NestedIfExample

} //namespace
