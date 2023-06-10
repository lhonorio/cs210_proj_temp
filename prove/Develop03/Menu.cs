public class Menu
{
    List<Scriptures> _scriptList = new List<Scriptures>
    {
        new Scriptures("1 Nephi 3:7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
        new Scriptures("John 16:33", "These things I have spoken unto you, that in me ye might have peace. In the world ye shall have tribulation: but be of good cheer; I have overcome the world."),
        new Scriptures("John 21:15", "So when they had dined, Jesus saith to Simon Peter, Simon, son of Jonas, lovest thou me more than these? He saith unto him, Yea, Lord; thou knowest that I love thee. He saith unto him, Feed my lambs.")
    };

    public Menu()
    {

    }

    Scriptures randomScript = _scriptList.GetRandomScript(List<Scriptures> _scriptList)
}