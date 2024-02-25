namespace dt_web_app.DTOs;
public class GenericResponse<TData, TError>
{
    public required TData Data { get; set; }
    public required TError Error { get; set; }
}