<!DOCTYPE html>
<html lang="fr">
<head>
    <meta charset="UTF-8">
    <title>Connexion - Hôtel XYZ</title>
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
    </header>
<main>
    <div class="form-container">
        <h2>Connexion</h2>
        <form action="process-login.php" method="post">
            <input type="email" name="email" placeholder="Email" required>
            <input type="password" name="password" placeholder="Mot de passe" required>
            <button type="submit">Connexion</button>
        </form>
    </div>
</main>

<script src="script.js"></script>
</body>
</html>
