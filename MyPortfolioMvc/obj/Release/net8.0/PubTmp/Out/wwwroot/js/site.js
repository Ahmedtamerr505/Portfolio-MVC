document.addEventListener("DOMContentLoaded", function () {
    const typingElement = document.querySelector(".typing");
    const words = ["a Developer", "a Front-end ", "a Back-end.NET"]; // Add your phrases here
    let wordIndex = 0;
    let text = "";
    let isDeleting = false;

    function type() {
        if (!typingElement) return;

        // Determine the current word and adjust text based on deletion or typing
        const currentWord = words[wordIndex];
        if (isDeleting) {
            text = currentWord.substring(0, text.length - 1); // Remove a character
        } else {
            text = currentWord.substring(0, text.length + 1); // Add a character
        }

        // Update the displayed text
        typingElement.textContent = text;

        // If the word is fully typed, pause before deleting
        if (!isDeleting && text === currentWord) {
            isDeleting = true;
            setTimeout(type, 1000); // Pause for 1 second
        }
        // If the text is fully deleted, move to the next word
        else if (isDeleting && text === "") {
            isDeleting = false;
            wordIndex = (wordIndex + 1) % words.length; // Loop back to the start
            setTimeout(type, 200); // Pause briefly before typing the next word
        }
        // Typing or deleting continues
        else {
            setTimeout(type, isDeleting ? 50 : 100);
        }
    }

    type(); // Start the typing animation
});
