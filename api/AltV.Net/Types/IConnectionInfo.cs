namespace AltV.Net.Types;

public interface IConnectionInfo : INative
{
    string Name { get; }
    ulong SocialClubId { get; }
    ulong HardwareIdHash { get; }
    ulong HardwareIdExHash { get; }
    string AuthToken { get; }
    bool IsDebug { get; }
    string Branch { get; }
    uint Build { get; }
    string CdnUrl { get; }
    ulong PasswordHash { get; }
    string Ip { get; }
    long DiscordUserId { get; }
    long Id { get; }
    string SocialName { get; }

    void Accept(bool sendNames = true);
    void Decline(string reason);
}