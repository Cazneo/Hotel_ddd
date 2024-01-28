document.addEventListener('DOMContentLoaded', function() {
    document.getElementById('cover').style.height = '30vh';
});
,document.addEventListener('DOMContentLoaded', function() {
    document.querySelector('form').addEventListener('submit', function(event) {
        let isValid = true;
       
        document.querySelectorAll('input[type="date"]').forEach(function(input) {
            // if (!input.value) isValid = false;
        });
        if (!isValid) {
            event.preventDefault();
            alert('Veuillez remplir toutes les dates.');
        }
    });
});