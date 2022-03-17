// Implement a function that receives two IPv4 addresses, and returns the number of addresses between them (including the first one, excluding the last one).
// All inputs will be valid IPv4 addresses in the form of strings. The last address will always be greater than the first one.
// Examples
// ips_between("10.0.0.0", "10.0.0.50")  ==   50 
// ips_between("10.0.0.0", "10.0.1.0")   ==  256 
// ips_between("20.0.0.10", "20.0.1.0")  ==  246

using System;

Console.WriteLine(CountIPAddresses.IpsBetween("10.0.0.0", "10.0.0.50"));
Console.WriteLine(CountIPAddresses.IpsBetween("20.0.0.10", "20.0.1.0"));
Console.WriteLine(CountIPAddresses.IpsBetween("0.0.0.0", "255.255.255.255"));

public class CountIPAddresses
{
   public static long IpsBetween(string start, string end)
   {
      string[] start_str = start.Split(".");
      long ip_start_long = long.Parse(start_str[0]) << 24 | long.Parse(start_str[1]) << 16 | long.Parse(start_str[2]) << 8 | long.Parse(start_str[3]);
      string[] end_str = end.Split(".");
      long ip_end_long = long.Parse(end_str[0]) << 24 | long.Parse(end_str[1]) << 16 | long.Parse(end_str[2]) << 8 | long.Parse(end_str[3]);
      return ip_end_long - ip_start_long;
   }
}