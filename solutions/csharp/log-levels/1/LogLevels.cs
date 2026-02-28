using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        // On localise la position de "]:" et on extrait le texte après
        int index = logLine.IndexOf("]: ") + 3; // on ajoute 3 pour passer au delà de "]: "
        
        // On extrait le message et on supprime les espaces blancs au début et à la fin
        return logLine.Substring(index).Trim();
    }

    public static string LogLevel(string logLine)
    {
        //Trouver la position de début du niveau de log en localisant le crochet ouvrant "["
        int startIndex = logLine.IndexOf("[") + 1; // +1 pour ignorer le crochet lui-meme
        
        //Trouver la position de fin en localisant le crochet fermant ']'
        int endIndex = logLine.IndexOf("]");
        
        // Extraire le niveau de log et le convertir en minuscules pour la cohérence 
        return logLine.Substring(startIndex, endIndex - startIndex).Trim();
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string level = LogLevel(logLine);
        return $"{message} ({level})";

    }
}
