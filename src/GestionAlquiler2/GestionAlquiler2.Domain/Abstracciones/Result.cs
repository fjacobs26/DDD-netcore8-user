﻿using MediatR;
using System.Runtime.InteropServices;
namespace GestionAlquiler2.Domain.Abstracciones;

public class Result
{
    protected internal Result(bool isSuccess, Error error)
    {
        if(isSuccess && error != Error.None) {
            throw new InvalidOperationException();
        }if(!isSuccess && error == Error.None) {
            throw new InvalidOperationException();
        }
        IsSuccess = isSuccess;

        Error = error;
    }
    public bool IsSuccess { get; }
    public Error Error { get; }

    public static Result Success() => new(true, Error.None);

    public static Result Failure(Error error) => new(false, error);
    public static Result<TValue> Success<TValue>(TValue value)
    => new(value, true, Error.None);


    public static Result<TValue> Failure<TValue>(Error error)
        => new(default, false, error);

    public static Result<TValue> Create<TValue>(TValue value) => value is not null ? Success(value) : Failure<TValue>(Error.NullValue);
}
public class Result<TValue> : Result
{
    private readonly TValue _value;

    protected internal Result(TValue value, bool isSuccess, Error error): base(isSuccess, error) { 
        _value = value;
    }

    public static implicit operator Result<TValue>(TValue result) => Create(result);

}