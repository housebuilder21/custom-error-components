# custom-error-components

While working on a project, I was tired of writing/copying the same code over and over again in the fronend code for Razor pages. They always go something like this:

```c#
@* Single String Error Message *@
@if (!string.IsNullOrWhiteSpace(_errorMessage))
{
    <MudAlert [insert properties here]>
        @_errorMessage
    </MudAlert>
}

@* List of Error Messages*@
<MudAlert [insert properties here]>
    <MudText>Some errors were found:</MudText>
    @foreach (var message in _errorMessages)
    {
        @_message
    }
</MudAlert>
```

With my new component, that could be compressed down to a simple one-liner like this:

```C#
@* Single Message *@
<ErrorGeneric Message="_errorMessage" Class="[any classes needed go here]" Style="[any styling needed go here]" />

@* Messages List *@
<ErrorDropdown Message="_errorMessages" Class="[any classes needed go here]" Style="[any styling needed go here]" />
```

To view the code/page that perviews these components, check out `Components/Pages/ErrorComponentsTesting.razor`. The Error components themselves live in `Components/Errors`.

[Errors Showoff](preview.png)