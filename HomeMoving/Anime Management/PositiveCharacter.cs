namespace Anime;

public class PositiveCharacter : AnimeCharacter
{
    private int numberOfEpisodes;
    private int powerLevel;
    private bool isMainCharacter;
    
    public PositiveCharacter(){} 
    public PositiveCharacter(int characterID, string characterName, string animeName,int numberOfEpisodes,int powerLevel,bool isMainCharacter)
        : base(characterID, characterName, animeName)
    {
        this.numberOfEpisodes = numberOfEpisodes;
        this.powerLevel = powerLevel;
        this.isMainCharacter = isMainCharacter;
    }

    public void setNumberOfEpisodes(int numberOfEpisodes)
    {
        this.numberOfEpisodes = numberOfEpisodes;
    }

    public void setPowerLevel(int powerLevel)
    {
        this.powerLevel = powerLevel;
    }

    public void setIsMainCharacter(bool isMainCharacter)
    {
        this.isMainCharacter = isMainCharacter;
    }

    public int getNumberOfEpisodes()
    {
        return this.numberOfEpisodes;
    }

    public int getPowerLevel()
    {
        return this.powerLevel;
    }

    public bool getIsMainCharacter()
    {
        return this.isMainCharacter;
    }

    public void showInfo()
    {
        base.showInfo();
        Console.WriteLine("Number of Episodes: " + this.numberOfEpisodes);
        Console.WriteLine("Power Level: " + this.powerLevel);
        Console.WriteLine("Is Main Character: " + this.isMainCharacter);
        
    }

    public override bool checkPopularity()
    { return ((isMainCharacter && powerLevel > 9000 && numberOfEpisodes > 150) || (!isMainCharacter && numberOfEpisodes > 90)? true : false);
    }
}