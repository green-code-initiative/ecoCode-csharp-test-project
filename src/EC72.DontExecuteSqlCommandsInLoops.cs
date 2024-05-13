using System.Data;

namespace EcoCode.LiveWarnings;

internal static class DontExecuteSqlCommandsInLoops
{
    public static void Run()
    {
        var command = default(IDbCommand)!; // EC82, code fix: const IDbCommand command = default!;
        _ = command.ExecuteNonQuery();
        _ = command.ExecuteScalar();
        _ = command.ExecuteReader();
        _ = command.ExecuteReader(CommandBehavior.Default);

        for (int i = 0; i < 10; i++)
        {
            _ = command.ExecuteNonQuery(); // EC72
            _ = command.ExecuteScalar(); // EC72
            _ = command.ExecuteReader(); // EC72
            _ = command.ExecuteReader(CommandBehavior.Default); // EC72
        }
    }
}
