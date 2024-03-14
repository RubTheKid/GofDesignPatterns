using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuizComposite;
//Leaf
public class Question : QuizItem
{
    public Question(string description) : base(description)
    { }

    public override void Display()
    {
        Console.WriteLine($"Question: {Description}");
    }
}
