﻿namespace ObslugaTPay.Helpers.Contracts
{
    public interface IHashCalculator
    {
        string Md5Sum(string id, string amount, string crc, string code);
        string TimeHash(string expirationDate, string code);
    }
}