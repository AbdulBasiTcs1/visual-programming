// q2. Develop C sharp console application that processes student marks usind 2d arrays. Tha application should 1. accept the marks of 3 students in 4 subjects and store them in 2d array 2. Calculate and display the total and average of marks of each student 3. dETERMINE  and display highest marks in each subject 4.Presents the results in a table with proper headings.
// q1. Develop a window form student login application with limited login . the application should 1. Provide text boxes for username and password and ensure that password is not visible to user 2. Provide a show password checkbox that shows or hides the password when checked or unchecked 3.checked the entered username and passwords against stored credientials (details we written) and lock the login button after 3 login attempts 4. Display the number of remaining attempts in a labelafter each failed login (for exampe 2 attempts reminig) 5. Display a message box if the username or password field is left empty without counting it as a failed attempt 6. Provide a clear button that empties both textboxes, unchecks show password and moves the cursor to the  username text box 7. On a successful login open a dashboard form that displays welcome with a login date and time and hide the login form. Provide a log out button on the dashboard that closes it and shows the login form again.
// q3. Develop a windows form notes application that demonstrates file handling. The application should 1. Provide a multiline textbox and 2 buttons open and save - save the text into a file chosen through 
// q4. Develop a windors form web browser with basic navigation the apllication should 1. Provide a textbox for url and the buttons go back forward refresh and home 2. add https collon automatically if teh user doesbnnto type it and navigatew when enter us pressed in tecxtbox or when user clciks on button 3. Disable the back and forward buttons when no previous or next page is avauuilable 4. Show loading in a laebl while a page loads and the page title when loading completes.
// q5. Develop a windows form aplication that shows a splash screen with a progess bar beofre the main form opens. the application should : 1. Display a border less splash form in the center of screen with a picture box logo and application name 2. Use a timer to increase a progress bar from 0 to 100 and display it in a label 3. When the progress bar reaches 100stop the timer, open the login form and hides splash form 4.Exit the whole application when the main form is closed 

// q2. Develop C sharp console application that processes student marks usind 2d arrays. Tha application should 1. accept the marks of 3 students in 4 subjects and store them in 2d array 2. Calculate and display the total and average of marks of each student 3. dETERMINE  and display highest marks in each subject 4.Presents the results in a table with proper headings.

using System;
class Program
{

    static void Main(String[] args)
    {
        int[,] marks = new int[3, 4];
        int[] total = new int[3];
        double[] average = new double[3];

        string[] subjects = { "Subject 1", "Subject 2", "Subject 3", "Subject 4" };

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Enter marks for Student " + (i + 1) + ":");

            for (int j = 0; j < 4; j++)
            {
                Console.Write("Enter marks in " + subjects[j] + ": ");
                marks[i, j] = int.Parse(Console.ReadLine());

                total[i] = total[i] + marks[i, j];
            }

            average[i] = total[i] / 4.0;
        }

        Console.WriteLine();
        Console.WriteLine("Student \t Sub 1\tSub 2\tSub 3\tSub 4\tTotal\tAverage");

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Student " + (i + 1) + "\t");

            for (int j = 0; j < 4; j++)
            {
                Console.Write(marks[i, j] + "\t");
            }

            Console.WriteLine(total[i] + "\t" + average[i].ToString("F2"));
        }

        Console.WriteLine();
        Console.WriteLine("Highest marks in each subject:");



        for (int j = 0; j < 4; j++)
        {
            int highest = marks[0, j];

            for (int i = 1; i < 3; i++)
            {
                if (marks[i, j] > highest)
                {
                    highest = marks[i, j];
                }
            }

            Console.WriteLine(subjects[j] + ": " + highest);
        }
    }
}


