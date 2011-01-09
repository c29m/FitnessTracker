﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<FitnessTracker.Models.ExerciseType>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <table>
        <tr>
            <th></th>
            <th>
                Id
            </th>
            <th>
                Name
            </th>
            <th>
                Distance Used?
            </th>
            <th>
                Min Seconds/Mile
            </th>
            <th>
                Max Seconds/Mile
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%= Html.ActionLink("Edit", "Edit", new { id=item.ExerciseTypeId }) %> |
                <%= Html.ActionLink("Details", "Details", new { id=item.ExerciseTypeId })%> |
                <%= Html.ActionLink("Delete", "Delete", new { id=item.ExerciseTypeId })%>
            </td>
            <td>
                <%= Html.Encode(item.ExerciseTypeId) %>
            </td>
            <td>
                <%= Html.Encode(item.Name) %>
            </td>
            <td>
                <%= Html.Encode(item.IsDistanceUsed) %>
            </td>
            <td>
                <%= Html.Encode(item.MinSecondsPerMile) %>
            </td>
            <td>
                <%= Html.Encode(item.MaxSecondsPerMile) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%= Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

