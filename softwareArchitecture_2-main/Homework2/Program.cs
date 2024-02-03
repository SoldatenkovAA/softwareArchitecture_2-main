using Homework2.Decorator;
using Homework2.Factory_Method;

Console.WriteLine("Factory Method");
Random random = new Random();
List<Composers> composers = [new SongComposer(), new DanceComposer(), new OperaComposer()];

for (int i = 0; i < 10; i++)
{
    Composition composition = composers[Math.Abs((random.Next() % composers.Count))].createComposition();
}

Console.WriteLine("Decorator");
Insect butterfly = new Butterfly();
Insect beatle = new Beatle();

Console.WriteLine("Название: {0}", butterfly.Title);
Console.WriteLine("Умеет: {0}", butterfly.getSkill());
Console.WriteLine("Название: {0}", beatle.Title);
Console.WriteLine("Умеет: {0}", beatle.getSkill());

Insect butterfly1 = new PollateInsect(butterfly);
Insect beatle1 = new PollateInsect(beatle);
Insect butterfly2 = new FlyInsect(butterfly1);

Console.WriteLine("Название: {0}", butterfly1.Title);
Console.WriteLine("Умеет: {0}", butterfly1.getSkill());
Console.WriteLine("Название: {0}", beatle1.Title);
Console.WriteLine("Умеет: {0}", beatle1.getSkill());
Console.WriteLine("Название: {0}", butterfly2.Title);
Console.WriteLine("Умеет: {0}", butterfly2.getSkill());