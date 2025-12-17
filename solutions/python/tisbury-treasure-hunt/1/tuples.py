def get_coordinate(record):
    return record[1]

def convert_coordinate(coordinate):
    return tuple(coordinate)

def compare_records(azara_record, rui_record):
    return tuple(azara_record[1])==rui_record[1]

def create_record(azara_record, rui_record):
    return azara_record+rui_record if compare_records(azara_record, rui_record) else "not a match"

def clean_up(combined_record_group):
    return "".join([f"{(record[0], record[2], record[3], record[4])}\n" for record in combined_record_group])
