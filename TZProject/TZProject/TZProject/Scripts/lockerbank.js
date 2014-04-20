var selection;
var highlightColour = "#DEDE00";
var normalColor = "#FF6B00";

$(function () {
    $(".container tr td > div").click(function () {

        if (selection == null || selection.attr("id") != $(this).attr("id")) {
            if (selection != null) {
                selection.attr("stop", 1);
            }
            selection = $(this);
            selection.attr("stop", 0);
            flash(selection, highlightColour, 500);
        }
    });
});

function flash(s, color, duration)
{
    if (s != null) {
        s.animate({
            backgroundColor: color
        }, duration, function () {
            if (s.attr("stop") == 1 && color == normalColor) return;
            if (color == highlightColour) color = normalColor;
            else color = highlightColour;
            flash(s, color, duration);
        });
    }
}