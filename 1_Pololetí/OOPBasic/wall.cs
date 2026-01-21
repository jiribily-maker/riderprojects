class wall
{
    public float height;
    public float width;
    public string material;

    public wall(float height, float width, string material)
    {
        this.height = height;
        this.width = width;
        this.material = material;
    }

    public float GetSurface()
    {
        return height * width;
    }

    public void PrintInfo()
    {
        Console.WriteLine(" Wall material: " + material + ", Wall surface: " +  GetSurface() + "^2");


    }
}

