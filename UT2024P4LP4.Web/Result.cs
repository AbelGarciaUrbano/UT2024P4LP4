﻿using UT2024P4LP4.Web.Data.Dtos;
using UT2024P4LP4.Web.Data.Entities;

namespace UT2024P4LP4;
/// <summary>
/// Resultado simple
/// </summary>
public class Result
{
    public bool Succesd { get; set; }
    public string Message { get; set; } = "";

    public static Result Success(string message)
    => new()
    {
        Succesd = true,
        Message = message
    };
    public static Result Failure(string message)
    => new()
    {
        Message = message
    };
}
public class Result<T> : Result
{
    public T? Data { get; set; }
    public static Result<T> Success(T data, string message = "Ok")
    => new()
    {
        Data = data,
        Succesd = true,
        Message = message
    };
    public static new Result<T> Failure(string message)
    => new()
    {
        Message = message
    };
}
public class ResultList<T> : Result
{
    public ICollection<T>? Data { get; set; }
    public static ResultList<T> Success(ICollection<T> data, string message = "Ok")
    => new()
    {
        Data = data,
        Succesd = true,
        Message = message
    };
    public static new ResultList<T> Failure(string message)
    => new()
    {
        Message = message
    };

    internal static ResultList<CategoriaDto> Success(List<Categoria> categorias)
    {
        throw new NotImplementedException();
    }
}