
public class Produto{
    //C# - Construtor
public  Produto(){
    Id = Guid.NewGuid().ToString();
    CriadoEm = DateTime.Now;
}


    //C# - atributos/prioridades - Caracteristicas
    public string Id {get; set;}
    public double Valor {get; set;}
    public string Nome {get; set;}
    public int Quantidade {get; set;}
    public DateTime CriadoEm {get; set;}
    

    /*//JAVA = atributos/propriedades 
    private double valor;
}
//getters e setters
public void setValor(double valor){
    this.valor = valor * 3;
}

public void getValor(){
    return this.valor;*/
}