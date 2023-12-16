using TL;

using var client = new WTelegram.Client(Config);

await client.LoginUserIfNeeded();

await client.SendMessageAsync(InputPeer.Self, "hello world");

Console.WriteLine("Hello, World!");
return;

static string? Config(string what)
{
    switch (what)
    {
        case "session_pathname":  return Path.Join(Environment.CurrentDirectory, "mysessionFILE.session");
        case "api_id":            return "YOUR_API_ID";
        case "api_hash":          return "YOUR_API_HASH";
        case "phone_number":      return "+12025550156";
        case "verification_code": Console.Write("Code: "); return Console.ReadLine()!;
        case "first_name":        return "John";    // if sign-up is required
        case "last_name":         return "Doe";     // if sign-up is required
        case "password":          return "secret!"; // if user has enabled 2FA
        default:                  return null;
    }
}