<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<FitnessTracker.Models.WorkoutViewModel>" %>

<% using (Html.BeginForm()) {%>
    <%= Html.ValidationSummary(true) %>
    
        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Workout.StartingTime) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Workout.StartingTime, String.Format("{0:g}", Model.Workout.StartingTime)) %>
                <%= Html.ValidationMessageFor(model => model.Workout.StartingTime) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Workout.NumDistanceUnits)%>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Workout.NumDistanceUnits, String.Format("{0:F}", Model.Workout.NumDistanceUnits))%>
                <%= Html.ValidationMessageFor(model => model.Workout.NumDistanceUnits)%>

                <%= Html.DropDownListFor(model => model.Workout.DistanceUnitId,
                                                    Model.DistanceUnitTypeList) %>
                <%= Html.ValidationMessageFor(model => model.Workout.DistanceUnitId)%>

            </div>
            
            <% var timeUnitAttr = new { maxlength = 5, size = 30 }; %>

            <div class="editor-label">
                <%= Html.LabelFor(model => model.Workout.TotalSeconds) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Workout.Minutes, timeUnitAttr) %>
                <%= Html.ValidationMessageFor(model => model.Workout.Minutes) %>
                minutes, 
                <%= Html.TextBoxFor(model => model.Workout.Seconds, timeUnitAttr) %>
                <%= Html.ValidationMessageFor(model => model.Workout.Seconds) %>
                seconds
            </div>
            
            <p>
                <input type="submit" value="Save" />
            </p>
        </fieldset>

<% } %>
