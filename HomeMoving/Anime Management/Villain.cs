namespace Anime;

public class Villain : AnimeCharacter
{
    private int evilscore;
    private string finalBattleOutcome;
    
    public Villain(){}

    public Villain(int characterID, string characterName, string animeName, int evilscore, string finalBattleOutcome)
    : base(characterID, characterName, animeName)
    {
       this.evilscore = evilscore;
       this.finalBattleOutcome = finalBattleOutcome;
    }

    public void setEvilscore(int evilscore)
    {
        this.evilscore = evilscore;
    }
    public int getEvilscore()
    {
        return this.evilscore;
    }

    public void setFinalBattleOutcome(string finalBattleOutcome)
    {
        this.finalBattleOutcome = finalBattleOutcome;
    }

    public string getFinalBattleOutcome(){
        return this.finalBattleOutcome;
        
    }

    public void showInfo()
    {
        Console.WriteLine("Villain Information:");
        base.showInfo();
        Console.WriteLine("Evilscore: " + this.evilscore);
        Console.WriteLine("FinalBattleOutcome: " + this.finalBattleOutcome);
    }

    public override bool checkPopularity()
    {
        return (evilscore >= 80 && finalBattleOutcome == "won") ? true : false;
    }
}