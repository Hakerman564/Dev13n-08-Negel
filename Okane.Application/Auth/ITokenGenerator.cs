using Okane.Domain;

namespace Okane.Application.Auth;

public interface ITokenGenerator
{
    string Generate(User user);
}