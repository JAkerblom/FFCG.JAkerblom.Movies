using System.Collections.Generic;

namespace FFCG.G4.CardGame.Game.Shuffler
{
    public interface IShuffelCards
    {
        List<Card> Shuffle(Stack<Card> cards);
    }
}