<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <title>Réservation - Hôtel XYZ</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>

    <header>
	
        <h1>Hôtel XYZ</h1>
        <nav>
            <ul>
                <li><a href="#home">Accueil</a></li>
                <li><a href="#rooms">Chambres</a></li>
                <li><a href="#booking">Réserver</a></li>
                <li><a href="#account">Mon Compte</a></li>
            </ul>
        </nav>
    </header

<main>
    <h2>Réservation</h2>
    <form action="process-booking.php" method="post">
        <!-- Ajouter ici les éléments du formulaire de réservation -->
        <input type="hidden" name="room_type" value="Chambre Standard">
        <input type="date" name="checkin_date" placeholder="Date d'arrivée" required>
        <input type="date" name="checkout_date" placeholder="Date de départ" required>
        <input type="number" name="guests" placeholder="Nombre de personnes" required>
        <button type="submit">Réserver</button>
    </form>
</main>

<!-- Ajouter ici le même pied de page (footer) -->

<script src="script.js"></script>
</body>
</html>
