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

    public static List<List<string>> SearchSmallWayStartEnd(){
        Dictionary<string, List<string>> map = new()
        {
            ["start"] = ["top1", "bottom1"],
            ["top1"] = ["mid1", "end"],
            ["bottom1"] = ["mid1", "bottom2"],
            ["mid1"] = [],
            ["bottom2"] = ["end"]
        };

        List<List<string>> listQueue = [["start"]];
        List<List<string>> ways = [];

        while (listQueue.Count > 0){
            List<string> path = listQueue[0];
            listQueue.RemoveAt(0);
            string node = path.Last();

            if(node == "end"){
                ways.Add(path);
                continue;
            }

            foreach(string neighbor in map[node]){
                if(!path.Contains(neighbor)){
                    listQueue.Add([..path, neighbor]);
                }
            }
        }

        return ways;

    }
}