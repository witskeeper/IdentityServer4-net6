using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace IdentityServer4.Extensions;

internal class CustomJwtPayload : JwtPayload
{
    public CustomJwtPayload(string issuer, string audience, IEnumerable<Claim> claims, DateTime? notBefore, DateTime? expires) :
        base(issuer, audience, claims, notBefore, expires)
    {
    }

    public override string SerializeToJson()
    {
        return JsonConvert.SerializeObject(this);
    }
}