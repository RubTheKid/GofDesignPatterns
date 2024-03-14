using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizComposite;

public abstract class QuizItem
{
    protected string Description;


    public QuizItem(string description)
    {
        Description = description;
    }

    public abstract void Display();
}
