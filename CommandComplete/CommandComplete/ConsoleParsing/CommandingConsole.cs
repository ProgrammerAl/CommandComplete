﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace CommandComplete.ConsoleParsing
{
    [ExcludeFromCodeCoverage]
    public class CommandingConsole : ICommandingConsole
    {
        /// <summary>
        /// Gets the next key pressed by a user in a console session
        /// </summary>
        /// <param name="hideKeyPressedInConsole">True to not display the key pressed in the console window</param>
        public ConsoleKeyInfo GetGetKey(bool hideKeyPressedInConsole) => Console.ReadKey(hideKeyPressedInConsole);

        /// <summary>
        /// Deletes characters from the end of the console screen
        /// </summary>
        /// <param name="lengthToDelete">Count of characters to delete from the end of ths console string</param>
        public void TrimEndCharacters(int lengthToDelete)
        {
            for (int i = 0; i < lengthToDelete; i++)
            {
                Console.Write("\b \b");
            }
        }

        public void Write(string textToAddToConsole) => Console.Write(textToAddToConsole);
        public void AppendCharacter(char keyChar) => Console.Write(keyChar);
    }
}
