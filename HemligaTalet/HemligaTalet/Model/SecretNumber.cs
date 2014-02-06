using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HemligaTalet.Model
{

    enum Outcome {Indefinite, Low, High, Correct, NoMoreGuesses, PreviousGuess};
    public class SecretNumber
    {
        private int _number;
        private List<int> _previousGuesses;
        private const int _MaxNumberOfGuesses = 7;

        public bool CanMakeGuess
        {
            get;
        }

        public int Count
        {
            get;
        }

        public int? Number
        {
            get;
        }

        public Outcome Outcome
        {
            get;
            set;
        }

        public IEnumerable<int> PreviousGuesses
        {
            get;
        }

        public void Initalize()
        {
            Random myRandom = new Random();
            _number = myRandom.Next(1, 101);
            Outcome = Outcome.Indefinite;

        }

        public Outcome MakeGuess(int guess)
        {

            if (guess > 100 || guess < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (!CanMakeGuess)
            {
                return Outcome.PreviousGuess;
            }

            if (guess == _number)
            {
                return Outcome.Correct;
            }

            if (_previousGuesses.Contains(guess))
            {
                return Outcome.PreviousGuess;
            }

            if (guess > _number)
            {
                return Outcome.High;
            }

            if (guess < _number)
            {
                return Outcome.Low;
            }

        }

        public SecretNumber()
        {
            Initalize();
        }
    }
}