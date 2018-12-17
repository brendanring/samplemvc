// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function showSampleThing(id) {
    //remove existing modal
    $("#sampleText").remove();

    var sampleObject = {
        "contentString": `You Clicked The Row with ID: ${id}`
    };
    var sampleContent = document.getElementById("sampleModalTemplate").innerHTML;
    var renderedSampleTemplate = Handlebars.compile(sampleContent);

    var renderedSampleOutput = renderedSampleTemplate(sampleObject);

    //append compiled handlebars output to body
    $("#mainContainer").append(renderedSampleOutput);
    $('body').bootstrapMaterialDesign();
    //show modal
}