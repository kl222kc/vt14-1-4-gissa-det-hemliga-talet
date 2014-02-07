using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HemligaTalet.Model
{

    public enum Outcome {Indefinite, Low, High, Correct, NoMoreGuesses, PreviousGuess};
    public class SecretNumber
    {
        private int _number;
        private List<int> _previousGuesses;
        private const int MaxNumberOfGuesses = 7;

        public bool CanMakeGuess
        {
            get
            {
                return Count < MaxNumberOfGuesses;
            }
        }

        public int Count
        {
            get
            {
                return _previousGuesses.Count;
            }
        }

        public int? Number
        {
            get
            {
                if (CanMakeGuess)
                {
                    return null;
                }
                else
                {
                    return _number;
                }
            }
        }

        public Outcome Outcome
        {
            get;
            set;
        }

        public IEnumerable<int> PreviousGuesses
        {
            get
            {
                return _previousGuesses;
            }
        }

        public void Initalize()
        {
            _previousGuesses.Clear();
            Random myRandom = new Random();
            _number = myRandom.Next(1, 101);
            Outcome = Outcome.Indefinite;

        }

        public Outcome MakeGuess(int guess)
        {

            if (guess > 100 || guess < 1)
            {
                throw new ArgumentOutOfRangeException("En gissning måste vara mellan 1 och 100");
            }

            else if (_previousGuesses.Contains(guess))
            {
                Outcome = Outcome.PreviousGuess;
            }
            else
            {
                _previousGuesses.Add(guess);

                if (!CanMakeGuess)
                {
                    Outcome = Outcome.NoMoreGuesses;
                }

                else if (guess == _number)
                {
                    Outcome = Outcome.Correct;
                }

                else if (guess > _number)
                {
                    Outcome = Outcome.High;
                }

                else if (guess < _number)
                {
                    Outcome = Outcome.Low;
                } 
            }

            return Outcome;
        }

        public SecretNumber()
        {
            _previousGuesses = new List<int>(MaxNumberOfGuesses);
            Initalize();
        }
    }
}