<?php 
$method = $_SERVER['REQUEST_METHOD'];

if(array_key_exists('log', $_GET) && $_GET['log'] == 'Zsolti|wcf') {

	switch($method) {
		case "GET":
		if(!empty($_GET['id'])) {
			$id = intval($_GET['id']);
			getBooks($id);
		} else getBooks();
		break;

		case "POST":
		insertBook();
		break;

		case "PUT":
		$id = intval($_GET['id']);
		updateBook($id);
		break;

		case "DELETE":
		$id = intval($_GET['id']);
		deleteBook($id);
		break;

		default:
		header("HTTP/1.0 405 Method Not Allowed");	
		break;
	}

	
} else {
	header('Content-Type: application/json');
	echo json_encode("WRONG LOG INFO", JSON_UNESCAPED_UNICODE);
}

function getBooks($id = 0) {
	$query = "SELECT * FROM books";
	if($id != 0) $query.=" WHERE id=".$id." LIMIT 1";
	include_once 'connection.php';
	$response = getList($query);

	header('Content-Type: application/json');
	echo json_encode($response);
}

function insertBook () {
	$data = json_decode(file_get_contents('php://input'), true);
	$query = "INSERT INTO books (Name, Rating, Length, ReleaseYear) VALUES (:Name, :Rating, :Length, :ReleaseYear)";
	$params = [
		":Name" => $data["Name"],
		":Rating" => $data["Rating"],
		":Length" => $data["Length"],
		":ReleaseYear" => $data["ReleaseYear"]
	];
	include_once 'connection.php';
	$response = executeDML($query, $params);
	header('Content-Type: application/json');
	echo json_encode($response, JSON_UNESCAPED_UNICODE);
}

function updateBook($id) {
	$data = json_decode(file_get_contents('php://input'), true);
	$query = "UPDATE books SET Name = :Name, Rating = :Rating, Length = :Length, ReleaseYear = :ReleaseYear WHERE id = :id";
	$params = [
		":Name" => $data["Name"],
		":Rating" => $data["Rating"],
		":Length" => $data["Length"],
		":ReleaseYear" => $data["ReleaseYear"],
		":id" => $id
	];
	include_once 'connection.php';
	$response = executeDML($query, $params);
	header('Content-Type: application/json');
	echo json_encode($response, JSON_UNESCAPED_UNICODE);
}

function deleteBook($id) {
	$query = "DELETE FROM books WHERE id=".$id;
	include_once 'connection.php';
	$response = getList($query);

	header('Content-Type: application/json');
	echo json_encode($response, JSON_UNESCAPED_UNICODE);
}	
?>