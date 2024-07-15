using AutoMapper;

namespace Core;

public interface IHaveCustomMaping
{
    void ApplyMaping(Profile customProfile);
}