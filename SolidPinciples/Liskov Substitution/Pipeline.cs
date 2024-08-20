namespace SolidPinciples.Liskov_Substitution;

public class Pipeline
{
    public virtual void Start()
    {
        Console.WriteLine("Starting pipeline...");
    }

    public virtual void Stop()
    {
        Console.WriteLine("Stopping pipeline...");
    }
}


public class GasPipeline : Pipeline
{
    public override void Start()
    {
        Console.WriteLine("Starting gas pipeline...");
    }

    public override void Stop()
    {
        Console.WriteLine("Stopping gas pipeline...");
    }

    public void Purge()
    {
        Console.WriteLine("Purging gas pipeline...");
    }
}


public interface IPipeline
{
    void Start();
    void Stop();
}

public interface IPurgeablePipeline : IPipeline
{
    void Purge();
}

public class LsGasPipeline : IPurgeablePipeline
{
    public void Start()
    {
        Console.WriteLine("Starting gas pipeline...");
    }

    public void Stop()
    {
        Console.WriteLine("Stopping gas pipeline...");
    }

    public void Purge()
    {
        Console.WriteLine("Purging gas pipeline...");
    }
}
