namespace QuizComposite;

class Program
{
    static void Main(string[] args)
    {
        var GroupA = new Group("A) Portuguese");

        var question1 = new Question("agente ou a gente?");
        var question2 = new Question("nós ou nois?");

        GroupA.Add(question1);
        GroupA.Add(question2);

        var GroupB = new Group("B) Physics");

        var question3 = new Question("one uno and one fusca, both at 80km/h in the turn, who is faster? ");

        GroupB.Add(question3);

        var rootGroup = new Group("Quiz");
        rootGroup.Add(GroupA);
        rootGroup.Add(GroupB);


        rootGroup.Display();
        Console.ReadKey();
    

        
    }

}