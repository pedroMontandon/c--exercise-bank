namespace verify;
using trybank;

public class Verify ()
{
    public static void VerifyAccount (int[] args)
    {
        for (int i = 0; i < Bank.Length; i++) {
            if (Bank[i, 0] == args[0] && Bank[i, 1] == args[1]) {
                throw new ArgumentException("A conta já está sendo usada!");
            }
        }
    }
}