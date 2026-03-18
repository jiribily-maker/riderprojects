var p = new MusicPlayer();
PlayAndWriteInfo(p);

void PlayAndWriteInfo(IPlayable p)
{
    Console.WriteLine("Some info");
    p.Play();
}

interface IPlayable
{
    void Play();
    void Pause();
}

interface ILoggable
{
    void LogInfo();
}

class MusicPlayer : IPlayable , ILoggable
{
    public void Play()
    {
        
    }

    public void Pause()
    {
        
    }

    public void LogInfo()
    {
        
    }
}
