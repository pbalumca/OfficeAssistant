using System;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;

[LuisModel("{c86d56eb-cf83-43f8-84e1-4505aa6192e6}", "{9a82fbf69dc545da913389399fa7b568}")]
[Serializable]
public class DefaultDialog : LuisDialog<object>
{
    [LuisIntent("")]
    public async Task None(IDialogContext context, LuisResult result)
    {
        await context.PostAsync("Sorry, I dont know what you wanted...."); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Snacks")]
    public async Task SnacksIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync("Sorry, I dont know what you wanted...."); //
        context.Wait(MessageReceived);
    }
}
