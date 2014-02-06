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

        }

        public Outcome MakeGuess(int guess)
        {
            
        }

        public SecretNumber()
        {

        }
    }
}