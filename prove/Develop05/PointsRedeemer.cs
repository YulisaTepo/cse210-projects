using System.IO;
public class PointsRedeemer
{
    private List<string> _quotes = new List<string> {"“When you climb up a ladder, you must begin at the bottom and ascend step by step, until you arrive at the top; and so it is with the principles of the Gospel - you must begin with the first, and go on until you learn all the principles of exaltation. But it will be a great while after you have passed through the veil before you will have learned them. It will be a great work to learn our salvation and exaltation even beyond the grave.”",
"“Happiness is the object and design of our existence; and will be the end thereof, if we pursue the path that leads to it; and this path is virtue, uprightness, faithfulness, holiness, and keeping all the commandments of God.”",
"“Whatever God requires is right, no matter what it is, although we may not see the reason there of until all of the events transpire.”",
"“A man is saved no faster than he gains knowledge”",
"“When God commands, do it!”",
"“The best way to obtain truth and wisdom is not to ask from books, but to go to God in prayer, and obtain divine teaching.”",
"“It is our duty to concentrate all our influence to make popular that which is sound and good, and unpopular that which is unsound. ”",
"“God judges men according to the use they make of the light which He gives them.”",
"“A man filled with the love of God, is not content with blessing his family alone, but ranges through the whole world, anxious to bless the whole human race.”",
"“The important consideration is not how long we can live but how well we can learn the lesson of life, and discharge our duties and obligations to God and to one another.”",
"“The nearer a person approaches the Lord, a greater power will be manifested by the adversary to prevent the accomplishment of His purposes.”",
"“Shall we not go on in such great a cause?”",
"“Education is the power to think clearly, the power to act well in the worlds work, and the power to appreciate life.”",
"“Honest hearts produce honest actions.”",
"“Never let a day pass that you will have cause to say, I will do better tomorrow.”",
"“True independence and freedom can only exist in doing what is right.”",
"“A good man, is a good man, whether in this church, or out of it.”",
"“We should never permit ourselves to do anything that we are not willing to see our children do.”",
"“Love the giver more than the gift.”"};
    Random random = new Random();
    public string GetRandomQuote()
    {
        int index = random.Next(_quotes.Count());
        return _quotes[index];
    }
    
}
