using Stratis.SmartContracts;

/// <summary>
/// Implementation of a single-use auction contract.
/// DISCLAIMER: For demonstration purposes only. We would recommend significant testing
/// before using the following code in your own applications.
/// </summary>
[Deploy]
public class HelloWorld : SmartContract
{
    private string Greeting
    {
        get 
        {
            return this.PersistentState.GetString("Greeting");
        }
        set
        {
            this.PersistentState.SetString("Greeting", value);
        }
    }

    public HelloWorld(ISmartContractState smartContractState)
        : base(smartContractState)
    {
        this.Greeting = "Hello World!";
    }

    public string SayHello()
    {
        return Greeting;
    }

}
