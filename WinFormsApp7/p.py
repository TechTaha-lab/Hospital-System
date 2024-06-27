import random

subjects = [
    "The cat", "A dog", "A teacher", "The scientist", "The artist", "A musician", 
    "The engineer", "A doctor", "The lawyer", "An astronaut", "A farmer", "The chef", 
    "A baker", "The dancer", "A writer", "The photographer", "A pilot", "The carpenter", 
    "A plumber", "The electrician", "A nurse", "The painter", "A soldier", "The gardener", 
    "A librarian", "The mechanic", "A driver", "The fisherman", "A sailor", "The actor", 
    "A director", "The producer", "A singer", "The designer", "A tailor", "The technician", 
    "A programmer", "The analyst", "A consultant", "The advisor", "A clerk", "The secretary", 
    "A manager", "The supervisor", "A coordinator", "The inspector", "A researcher", "The scientist", 
    "A philosopher", "The mathematician"
]
verbs = [
    "jumps over", "runs to", "paints", "analyzes", "writes", "sings", "dances", "cooks", 
    "bakes", "builds", "designs", "draws", "fixes", "drives", "flies", "sails", "hunts", 
    "fishes", "teaches", "learns", "reads", "studies", "examines", "researches", "develops", 
    "creates", "invents", "discovers", "explores", "travels", "hikes", "climbs", "swims", 
    "dives", "jogs", "runs", "skates", "skis", "bikes", "cycles", "competes", "wins", 
    "loses", "participates", "joins", "attends", "organizes", "leads", "manages", "directs"
]

objects = [
    "a fence", "a book", "a canvas", "a report", "a song", "a poem", "a novel", "a story", 
    "a meal", "a dish", "a project", "a plan", "a model", "a structure", "a car", "a plane", 
    "a boat", "a house", "a garden", "a field", "a test", "an experiment", "a procedure", 
    "a program", "a presentation", "a lecture", "a lesson", "a game", "a sport", "a competition", 
    "a concert", "a show", "a movie", "a play", "a role", "a costume", "a set", "a stage", 
    "a gallery", "an exhibit", "a museum", "a library", "a park", "a school", "a university", 
    "a hospital", "a clinic", "a laboratory", "a factory", "an office", "a store"
]

def generate_sentence():
    subject = random.choice(subjects)
    verb = random.choice(verbs)
    object_ = random.choice(objects)
    return f"{subject} {verb} {object_}."

def generate_story(num_sentences=5):
    story = [generate_sentence() for _ in range(num_sentences)]
    return " ".join(story)

if __name__ == "__main__":
    num_sentences = 5
    story = generate_story(num_sentences)
    print(story)
