namespace Anime;
public class AnimeCharacter
{
    public AnimeCharacter(){}
    private int characterID;
    private string characterName;
    private string animeName;

    public AnimeCharacter(int characterID, string characterName, string animeName)
    {
        this.characterID = characterID;
        this.characterName = characterName;
        this.animeName = animeName;
    }

    public void setCharacterID(int characterID)
    {
        this.characterID = characterID;
    }

    public void setCharacterName(string characterName)
    {
        this.characterName = characterName;
    }

    public void setAnimeName(string animeName)
    {
        this.animeName = animeName;
    }
    public int getCharacterID(){return this.characterID;}
    public string getCharacterName() { return this.characterName; }
    public string  getAnimeName() { return this.animeName; }

    public void showInfo()
    {
        Console.WriteLine("Character ID: " + this.characterID);
        Console.WriteLine("Character Name: " + this.characterName);
        Console.WriteLine("Anime Name: " + this.animeName);
        Console.WriteLine();
    }

    public virtual bool checkPopularity()
    {
        return false;
    }
}