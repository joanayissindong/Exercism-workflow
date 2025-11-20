class Badge {
    public String print(Integer id, String name, String department) {
        String idPrefix = id == null ? "" : String.format("[%d] - ", id);
        department = department == null ? "OWNER" : department.toUpperCase();
        return String.format("%s%s - %s", idPrefix, name, department);
    }
}