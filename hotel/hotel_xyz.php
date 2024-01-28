<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <title>Hôtel XYZ - Réservations</title>
    <link rel="stylesheet" href="style.css">
    <script src="script.js" defer></script>
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
    </header>
    
    <main>
        <section id="home" class="welcome">
            <!-- Contenu de bienvenue et présentation de l'hôtel -->
        </section>
        
        <section id="rooms">
            <!-- Présentation des chambres avec tarifs et équipements -->
        </section>
        
        <section id="booking">
            <!-- Formulaire de réservation -->
        </section>
        
        <section id="account">
            <!-- Formulaires de création de compte et d'alimentation du portefeuille -->
        </section>
    </main>

<div id="booking" class="booking-form">
    <h2>Réservez Votre Chambre</h2>
    <form action="reservation.php" method="post">
        <input type="date" name="checkin" placeholder="Date d'arrivée">
        <input type="date" name="checkout" placeholder="Date de départ">
        <input type="number" name="guests" placeholder="Nombre de personnes">
        <button type="submit">Vérifier la disponibilité</button>
    </form>
</div>

<script src="script.js"></script>
</body>
</html>