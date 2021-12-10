namespace LeetCode;

/// <summary>
/// <see href="https://leetcode.com/problems/course-schedule/">Course Schedule</see>.
/// </summary>
public static class Problem33
{
    /// <summary>
    /// There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1.
    /// You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must take course bi first if you want to take course ai.
    /// Return true if you can finish all courses. Otherwise, return false.
    /// Time complexity: O(n).
    /// Space complexity: O(n).
    /// </summary>
    /// <param name="numCourses">Number of courses.</param>
    /// <param name="prerequisites">Array to traverse.</param>
    /// <returns>True, if all courses can be finished.</returns>
    public static bool CanFinish(int numCourses, int[][] prerequisites)
    {
        var dict = new Dictionary<int, IList<int>>();

        for (var i = 0; i < prerequisites.Length; i++)
        {
            if (!dict.ContainsKey(prerequisites[i][0]))
            {
                dict.Add(prerequisites[i][0], new List<int>());
            }

            dict[prerequisites[i][0]].Add(prerequisites[i][1]);
        }

        var visited = new HashSet<int>();
        var currentPath = new HashSet<int>();

        for (var i = 0; i < prerequisites.Length; i++)
        {
            if (HasCycle(prerequisites[i][0], dict, visited, currentPath))
            {
                return false;
            }
        }

        return dict.Count <= numCourses;
    }

    private static bool HasCycle(int course, IDictionary<int, IList<int>> dict, ISet<int> visited, ISet<int> currentPath)
    {
        if (!currentPath.Add(course))
        {
            return true;
        }

        if (visited.Add(course) && dict.ContainsKey(course))
        {
            foreach (var prerequisite in dict[course])
            {
                if (HasCycle(prerequisite, dict, visited, currentPath))
                {
                    return true;
                }
            }
        }

        return !currentPath.Remove(course);
    }
}
