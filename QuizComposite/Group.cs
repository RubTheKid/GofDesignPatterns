using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizComposite;

//composite
public class Group : QuizItem
{
    private IList<QuizItem> _items = new List<QuizItem>();

    public Group(string description) : base(description)
    {

    }
    public override void Display()
    {
        Console.WriteLine($"Group {Description}");

        foreach(var item in _items)
        {
            item.Display();
        }
    }

    public void Add(QuizItem item)
    {
        _items.Add(item);
    }
    
    public void Remove(QuizItem item) 
    { 
        _items.Remove(item);
    }
}
