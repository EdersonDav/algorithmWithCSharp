namespace Implementations;

class BreadthFirstSearch
{

    public static bool PersonIsMangoSeller(string person)
    {
        return person == "Thom";
    }
    public static string SearchAMangoSeller()
    {
        Dictionary<string, List<string>> friends = new()
        {
            ["You"] = ["Alice", "Bob", "Claire"],
            ["Bob"] = ["Anuj", "Peggy"],
            ["Alice"] = ["Peggy"],
            ["Claire"] = ["Thom", "Jonny"],
            ["Anuj"] = [],
            ["Peggy"] = [],
            ["Thom"] = [],
            ["Jonny"] = []
        };

        List<string> searchList = friends["You"];
        List<string> notSellers = [];
        string seller = "Seller not found";
        while (searchList.Count > 0)
        {
            string person = searchList[0];
            searchList.RemoveAt(0);

            if (!notSellers.Contains(person))
            {
                if (!PersonIsMangoSeller(person))
                {
                    notSellers.Add(person);
                    List<string> personFriends = friends[person];
                    searchList = [.. searchList, .. personFriends];
                }
                else
                {
                    seller = person;
                    break;
                }
            }

        }
        return seller;
    }
}