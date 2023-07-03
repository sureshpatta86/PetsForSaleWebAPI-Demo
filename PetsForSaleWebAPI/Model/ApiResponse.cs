namespace PetsForSaleWebAPI.Model;
public class ApiResponse
{
    public string Code { get; set; }
    public string Message { get; set; }
    public object? ResponseData { get; set; }
}

public enum ResponseType
{ 
    Sucess,
    NotFound,
    Failure
}
