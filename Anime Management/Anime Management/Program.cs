using Anime;

public class Program
{
    public static void Main()
    {
        AnimeCharacter ac = new AnimeCharacter(1,"Sakib","janina");
        ac.showInfo();
        Villain v = new Villain(1, "sadman", "janina", 7000, "yes");
        v.showInfo();
    }
}