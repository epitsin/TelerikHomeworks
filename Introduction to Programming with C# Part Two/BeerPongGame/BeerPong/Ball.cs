using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

public class Ball
{
    int X;
    int Y;
    double strength;
    public ConsoleColor ballColor;
    Func<int, int> direction = x => ++x;
    bool hit = false;



    /// <summary>
    /// A constructor for each new ball. Supports parameter validation.
    /// </summary>
    /// <param name="color">The color, sincronized with the player's color.</param>
    /// <param name="Y">The starting height of the throwing point (from top)</param>
    /// <param name="strength">The initial strength of the throw 
    /// (subject to random deviations when the player is drunk)</param>
    public Ball(ConsoleColor color, int Y = 6, double strength = 15)
    {
        this.X = 1;
        this.ballColor = color;
        if (Y >= 6 && Y <= Console.WindowHeight)
        {
            this.Y = Y;
        }
        if (strength > 0)
        {
            this.strength = strength;
        }
    }


    /// <summary>
    /// A map of the console window, used for the ball's trajectory.
    /// To be put out later with a Print method.
    /// </summary>
    static bool[,] field = new bool[Console.BufferWidth, Console.BufferHeight];

    /// <summary>
    /// This is the part of drawing the cups that is used to check for collisions with te ball
    /// </summary>
    /// <param name="width">From Left</param>
    /// <param name="height">From Top</param>
    public static void FillField(int width, int height)
    {
        field[width, height] = true;
    }


    void Trace()
    {
        Console.ForegroundColor = ballColor;
        try
        {
            Console.SetCursorPosition(this.X, this.Y);
        }
        catch (ArgumentOutOfRangeException)
        {
            return;
        }
        Console.Write("o");
        Thread.Sleep(25);
    }

    /// <summary>
    /// Moves right by 'momentum' places and checks for collisions
    /// </summary>
    /// <param name="Y"></param>
    /// <param name="momentum">A coefficient, relative to the initial strength of the throw</param>        
    void Fly(int Y, double momentum)
    {
        for (int i = 0; i < momentum; i++)
        {
            this.Trace();
            if (this.X > 0 && this.X < Console.BufferWidth && this.Y > 1)
            {
                if (field[this.X, this.Y])
                {
                    Ricochet();
                }
            }
            this.X = this.direction.Invoke(this.X);

        }
    }

    /// <summary>
    /// Move downwards by 1 level and checks for collision
    /// </summary>
    void Fall()
    {
        this.Trace();
        if (this.X > 0 && this.X < Console.BufferWidth && this.Y > 1)
        {
            if (field[this.X, this.Y])
            {
                this.hit = true;
            }
        }
        this.Y++;
    }

    /// <summary>
    /// It's a ping pong ball, it must bounce!
    /// </summary>
    /// <param name="momentum"></param>
    void Bounce(double momentum)
    {
        double potential = momentum * 2;
        while (momentum / 5 < potential)//Going up
        {
            for (int i = 0; i < potential / 4; i++)//Twisted Fly() by 90 degrees clockwise
            {
                this.Trace();
                this.Y--;
            }

            this.Trace();//Twisted Fall() by 90 degrees clockwise
            this.X = this.direction.Invoke(this.X);

            potential *= (1.0 / 2.0);
        }


        this.strength = potential * momentum / 2;

        this.Throw(0);//Going down

    }

    /// <summary>
    /// Reverses the direction of the ball 
    /// </summary>
    public void Ricochet()
    {
        this.direction = x => --x;
    }

    /// <summary>
    /// The official movement of the ball across the field, taking dunkenness in account
    /// </summary>
    public void Throw(int drunk)
    {
        Random deviance = new Random();
        int overThrow = deviance.Next(0 - drunk / 2, drunk / 2);

        if (drunk == 0) //Nerfing the initial 60p.
        {
            overThrow = deviance.Next(-1, 1);
        }
        
        this.strength += overThrow;//Alcohol affecting your throw
        double momentum = this.strength;                               
        while (this.Y < Console.BufferHeight - 1)
        {
            if (this.hit)//In case of a collision in the previous step
            {
                goto EndOfThrow;
            }
            //Regular flight
            if (momentum > 0.1)
            {
                Fly(this.Y, momentum);
                this.Fall();
                momentum *= (2.0 / 3.0);
            }
            else
            {
                this.Fall();
                momentum *= (2.0 / 3.0);
            }
            //Add collision

        }

        while (momentum > 0.2)
        {
            momentum /= 2.0;
            this.Bounce(momentum);
        }
    EndOfThrow: ;
    }

    /// <summary>
    /// Positioning the ball using arrow keys
    /// </summary>
    public void SetupBall()
    {
        Console.ForegroundColor = this.ballColor;
        Console.SetCursorPosition(this.X, this.Y);
        Console.Write("o|{0}", this.strength);

        while (Console.KeyAvailable) //Skipping any unnecessary Space-s
        {
            Console.ReadKey(false);
        }


        ConsoleKey keyPressed = Console.ReadKey(true).Key;
        while (keyPressed != ConsoleKey.Spacebar)
        {
            bool tooLow = false;
            try //For when we've reached bottom of console window
            {
                Console.SetCursorPosition(this.X, this.Y);
            }
            catch (ArgumentOutOfRangeException)
            {
                tooLow = true;
            }

            if (!tooLow)
                Console.ForegroundColor = this.ballColor;
            Console.Write("o|{0}", this.strength);
            keyPressed = Console.ReadKey(true).Key;


            Console.SetCursorPosition(this.X, this.Y);
            Console.ForegroundColor = Console.BackgroundColor;
            Console.Write("o|{0}", this.strength); //this deletes the last position of the throwhand but if in last row deletes it
            switch (keyPressed)
            {
                case ConsoleKey.DownArrow:
                    if (this.Y < Console.BufferHeight - 1) // -1 added because the last row max value = Console.BufferHeight - 1
                    {
                        this.Y++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    this.strength--;
                    if (this.strength < 0) //the strength can't be below zero
                        this.strength++;
                    break;
                case ConsoleKey.RightArrow:
                    this.strength++;
                    if (this.strength > 120) //sets the maximum strength the player cannot have infinite power ;)
                        this.strength--;
                    break;
                case ConsoleKey.UpArrow:
                    if (this.Y > 3)
                    {
                        this.Y--;
                    }
                    break;
                default:
                    break;
            }

        }

    }

    public int ScoreGained()
    {
        if (!hit)
        {
            return 0;
        }
        if (this.Y < 12)
        {
            return 60;
        }
        if (this.X >= 112)
        {
            return 25;
        }
        if (this.X >= 104)
        {
            return 20;
        }
        if (this.X >= 96)
        {
            return 15;
        }
        if (this.X >= 88)
        {
            return 10;
        }
        if (this.X >= 80)
        {
            return 5;
        }
        else return 0;
    }

}
