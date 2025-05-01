/*Validador de Senhas Fortes
Peça ao usuário que digite uma senha e verifique se ela atende aos seguintes critérios:
• Mínimo de 8 caracteres
• Pelo menos uma letra maiúscula
• Pelo menos um número
• Pelo menos um caractere especial (ex: !, @, #)*/


using System;

class Program
{
    public static void Main(string[] args)
    {
        bool senhaValida = false;

        do{
            Console.Write("Digite sua senha: ");
            string senha = Console.ReadLine();

            if (ValidarSenha(senha))
            {
                Console.WriteLine("Senha forte!");
                senhaValida = true;
            }
            else
            {
                Console.WriteLine("Senha fraca! Certifique-se de incluir pelo menos 8 caracteres, uma letra maiúscula, um número e um caractere especial.");
            }
        }while(!senhaValida);
    }

    public static bool ValidarSenha(string senha)
    {
        if (senha.Length < 8) return false;

        bool temMaiuscula = false;
        bool temNumero = false;
        bool temCaractereEspecial = false;

        foreach (char c in senha)
        {
            if (char.IsUpper(c)) temMaiuscula = true;
            if (char.IsDigit(c)) temNumero = true;
            if (!char.IsLetterOrDigit(c)) temCaractereEspecial = true;
        }

        return temMaiuscula && temNumero && temCaractereEspecial;
    }
}
