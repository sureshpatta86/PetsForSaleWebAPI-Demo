namespace PetsForSaleWebAPI.Model;
public class ResponseHandler
{
    public static ApiResponse GetExceptionResponse(Exception ex)
    {
        ApiResponse response = new()
        {
            Code = "1",
            Message = ex.Message
        };
        return response;
    }
    public static ApiResponse GetApiRespnse(ResponseType type, object? data)
    {
        ApiResponse response = new();
        switch (type)
        {
            case ResponseType.Sucess:
                response = new ApiResponse { Code = "0", Message = "Success",ResponseData=data };
                break;
            case ResponseType.NotFound:
                response = new ApiResponse { Code = "2", Message = "No data available", ResponseData = data };
                break;
        }
        return response;
    }
}
