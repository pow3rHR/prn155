class Automovil
{
    public string marca { 
        get { return "BMW"; }

        set {
            if(value == "Toyota") {
                Console.WriteLine("Utilice una marca distinta");
            }
        } 
    }
}

